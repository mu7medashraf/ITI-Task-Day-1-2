using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Task_EF_day3.Models;
namespace Task_EF_day3
{
    public partial class Form1 : Form
    {
        private readonly UniversityContext _context;
        private Student? _selectedStudent;

        public Form1()
        {
            InitializeComponent();
            _context = new UniversityContext();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }
        private async void Form1_Load(object? sender, EventArgs e)
        {
            await LoadStudentsAsync();
            SetButtonsDefault();
            if (!await _context.Students.AnyAsync())
            {
                var seedStudents = new[]
                {
            new Student { FullName = "Ahmed Ali", Age = 20, Email = "ahmed@test.com" },
            new Student { FullName = "Sara Mohamed", Age = 22, Email = "sara@test.com" },
            new Student { FullName = "Omar Hassan", Age = 19, Email = "omar@test.com" }
        };

                await _context.Students.AddRangeAsync(seedStudents);
                await _context.SaveChangesAsync();

            }
        }
        private async Task LoadStudentsAsync()
        {
            var list = await _context.Students.ToListAsync();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = list;
            if (dgvStudents.Columns["StudentId"] != null)
            {
                dgvStudents.Columns["StudentId"].Visible = false;
            }

        }

        private void SetButtonsDefault()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ClearInputs()
        {
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            _selectedStudent = null;
            SetButtonsDefault();
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter student name.");
                txtName.Focus();
                return false;
            }
            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                txtAge.Focus();
                return false;
            }
            return true;
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var student = new Student
            {
                FullName = txtName.Text.Trim(),
                Age = int.Parse(txtAge.Text.Trim()),
                Email = txtEmail.Text.Trim()
            };

            await _context.Students.AddAsync(student);
            var rows = await _context.SaveChangesAsync();
            MessageBox.Show($"Rows affected: {rows}");

            await LoadStudentsAsync();
            ClearInputs();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null || !ValidateInputs()) return;

            _selectedStudent.FullName = txtName.Text.Trim();
            _selectedStudent.Age = int.Parse(txtAge.Text.Trim());
            _selectedStudent.Email = txtEmail.Text.Trim();

            _context.Students.Update(_selectedStudent);
            await _context.SaveChangesAsync();

            await LoadStudentsAsync();
            ClearInputs();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null) return;

            var confirm = MessageBox.Show("Are you sure you want to delete this student?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            _context.Students.Remove(_selectedStudent);
            await _context.SaveChangesAsync();

            await LoadStudentsAsync();
            ClearInputs();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow?.DataBoundItem is Student s)
            {
                _selectedStudent = s;
                txtName.Text = s.FullName;
                txtAge.Text = s.Age.ToString();
                txtEmail.Text = s.Email;

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        
    }
}

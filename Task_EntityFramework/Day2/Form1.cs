using System;
using System.Linq;
using System.Windows.Forms;
using TaskDay2_EF.Models; 

namespace TaskDay2_EF
{
    public partial class Form1 : Form
    {
        private UniversityOnlyStudentsContext _context = new UniversityOnlyStudentsContext();
        private Student _selectedStudent;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _context.Students.Select(s => new
            {
                Name = s.FullName,
                Age = s.Age,
                Email = s.Email
            })
        .ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                FullName = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Email = txtEmail.Text
            };

            _context.Students.Add(student);
            _context.SaveChanges();
            LoadStudents();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null) return;

            _selectedStudent.FullName = txtName.Text;
            _selectedStudent.Age = int.Parse(txtAge.Text);
            _selectedStudent.Email = txtEmail.Text;

            _context.SaveChanges();
            LoadStudents();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null) return;

            _context.Students.Remove(_selectedStudent);
            _context.SaveChanges();
            LoadStudents();
            ClearInputs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            _selectedStudent = null;
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow?.DataBoundItem is Student s)
            {
                _selectedStudent = s;
                txtName.Text = s.FullName;
                txtAge.Text = s.Age.ToString();
                txtEmail.Text = s.Email;
            }
        }

       
    }
}

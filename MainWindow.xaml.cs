using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSI_122_Leature_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {



            AddStudentToList();
            DisplayStudents();

        }
        public void AddStudentToList()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCsiGrade.Text);
            double genEdGrade = double.Parse(txtGenEdGrade.Text);

            students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));

        }
        public void DisplayStudents()

        {
            runDisplay.Text = "";
            //this clears our display

            for (int i = 0; i < students.Count; i++)
            {
                runDisplay.Text += students[i] + "\n";
            }
        }
    }
}

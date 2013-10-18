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

namespace DataBindingExample
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ExampleViewModel exampleModel;
        TreeNode exampleTreeNode;

        public MainWindow()
        {
            exampleModel = new ExampleViewModel("John", "Smith", new List<String>(){ "lughead", "catdaddy", "lunker"});
            exampleTreeNode = TreeNode.GetTestData();

            InitializeComponent();

            stackPanel.DataContext = exampleModel;
            theTreeView.DataContext = exampleTreeNode;

            textBox1.Text = "Hello there!";

        }

        
    }
}

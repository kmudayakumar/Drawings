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

namespace WpfApplication2 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			
			
			InitializeComponent();

			IEnumerable<Person> l_Persons = new List<Person>();
			IEnumerable<PhoneNumber> l_PhoneNumbers = new List<PhoneNumber>();
		}
	}

	public class PhoneNumber {
		public int Number {
			get;
			set;
		}
	}

	public class Person {
		public string Name {
			get;
			set;
		}

		public IEnumerable<PhoneNumber> PhoneNumbers {
			get;
			set;
		}
	}
}

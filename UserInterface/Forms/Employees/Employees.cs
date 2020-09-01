using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.DataAccessLayer.ViewModel;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {

        #region Field
        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> fakeEmployees;
        #endregion

        #region Properties
        public static EmployeesForm Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }

        public static bool isNull
        {

            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion


        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }
        #endregion

        #region Private Methods
        private void PrepareEmployeesData() //zasilenie DataSource danymi
        {
            var fakeEmpolyessSorted = fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmpolyessSorted);
            dgvEmployess.DataSource = bsEmployees;

        }

        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Przybyłowski",
                    FirstName = "Jakub",
                    Code = 1,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1995, 7, 11),
                    PESEL = "95071107051",
                    PhoneNumber = "781452168",
                    EmailAdress = "jakub.przybylowski95@gmail.com",
                    IdentityCardNumber = "AWR1234524",
                    IssueDateIdentyCard = new DateTime(2018, 1, 1),
                    ExpirationDateIdentityCard = new DateTime(2023, 1, 1),
                    PassportNumber = "ER8948452",
                    IssueDatePassport = new DateTime(2015, 8, 24),
                    ExpirationDatePassport = new DateTime(2030, 1, 6),
                    Status = new StatusModel("Wprowadzony")
                },
                new EmployeeModel()
                {
                    Id = 2,
                    LastName = "Misiewicz",
                    FirstName = "Joanna",
                    Code = 2,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995, 4, 28),
                    PESEL = "95042804067",
                    PhoneNumber = "123456789",
                    EmailAdress = "joanna.misiewicz@gmail.com",
                    IdentityCardNumber = "AWR312515466",
                    IssueDateIdentyCard = new DateTime(2018, 11, 5),
                    ExpirationDateIdentityCard = new DateTime(2023, 5, 24),
                    PassportNumber = "ER23167983",
                    IssueDatePassport = new DateTime(2016, 10, 28),
                    ExpirationDatePassport = new DateTime(2030, 5, 9),
                    Status = new StatusModel("Wprowadzony")
                },
                new EmployeeModel()
                {
                    Id = 3,
                    LastName = "Kredka",
                    FirstName = "Michał",
                    Code = 3,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1980, 6, 15),
                    PESEL = "124395324953",
                    PhoneNumber = "987654321",
                    EmailAdress = "kredka.michal@gmail.com",
                    IdentityCardNumber = "AWR12452744",
                    IssueDateIdentyCard = new DateTime(2018, 11, 5),
                    ExpirationDateIdentityCard = new DateTime(2023, 5, 24),
                    PassportNumber = "ER1262342",
                    IssueDatePassport = new DateTime(2016, 10, 28),
                    ExpirationDatePassport = new DateTime(2030, 5, 9),
                    Status = new StatusModel("Wprowadzony")
                }
            };


            return MappingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }
        #endregion

        #region Events
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion


    }
}

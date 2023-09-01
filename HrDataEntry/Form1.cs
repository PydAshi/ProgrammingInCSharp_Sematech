using System.Security.Cryptography.Pkcs;

namespace HrDataEntry
{
    public partial class frmHrsInfo : Form
    {
        public frmHrsInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
               Person p1 = new Person();
                p1.FirstName = txtFirstName.Text;
                p1.LastName = txtLastName.Text;
                p1.MobileNumber = txtMobileNo.Text;
                p1.NationalCode = txtNationalCode.Text;
                p1.Sex = rdbMale.Checked;

                String strSex = "";




                if (p1.MobileNumber.Trim().Length < 10)
                {
                    MessageBox.Show("شماره تلفن همراه وارد شده صحیح نمی باشد.");
                }

                if (p1.NationalCode.Trim().Length != 10)
                {
                    MessageBox.Show("کد ملی باید 10 رقمی باشد.");

                }

                if (p1.Sex)
                {
                    strSex = "مرد";

                }
                else
                {
                    strSex = "زن";
                }


                MessageBox.Show("نام : " + p1.FirstName + " ، " + "نام خانوادگی :" + p1.LastName + " ، "
                                 + "شماره تلفن همراه : " + p1.MobileNumber + " ، " + "کد ملی : " + p1.NationalCode
                                 + " ، " + "جنسیت :" + strSex + " . ");


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //catch (ArgumentException ex)//** Tip: I Could not handle more than one exceptions.Could you please help me.
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}



        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("فقط مقادیر عددی قابل قبول می باشد.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
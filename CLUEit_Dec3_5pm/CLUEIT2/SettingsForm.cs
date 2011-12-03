using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLUEIT2
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            int index;
            //will pass in preferences colleciton
          //  foreach (preference in preferences)
            {
                index = dgvChooseSettings.Rows.Add();
              //  dgvChooseSettings.Rows[index].Cells["webService"].Value = preference.service_name;

               // if(preference.get_always_display())
                {
                    dgvChooseSettings.Rows[index].Cells["alwaysDisplayS"].Value = true;
                }
                
              //  else if(preference.get_never_display())
                {
                    dgvChooseSettings.Rows[index].Cells["neverDisplayS"].Value = true;
                }

              //  else
                {
                    dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                }


                //REMOVE remove all the ish below later
                index = dgvChooseSettings.Rows.Add();
                dgvChooseSettings.Rows[index].Cells["webService"].Value = "Google";
                dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                dgvChooseSettings.Rows[index].Cells["defaultS"].ReadOnly = true;

                index = dgvChooseSettings.Rows.Add();
                dgvChooseSettings.Rows[index].Cells["webService"].Value = "Wikipedia";
                dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                dgvChooseSettings.Rows[index].Cells["defaultS"].ReadOnly = true;

                index = dgvChooseSettings.Rows.Add();
                dgvChooseSettings.Rows[index].Cells["webService"].Value = "Images";
                dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                dgvChooseSettings.Rows[index].Cells["defaultS"].ReadOnly = true;

                index = dgvChooseSettings.Rows.Add();
                dgvChooseSettings.Rows[index].Cells["webService"].Value = "Maps";
                dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                dgvChooseSettings.Rows[index].Cells["defaultS"].ReadOnly = true;

                index = dgvChooseSettings.Rows.Add();
                dgvChooseSettings.Rows[index].Cells["webService"].Value = "Dictionary";
                dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                dgvChooseSettings.Rows[index].Cells["defaultS"].ReadOnly = true;

            }
        }

        private void dgvChooseSettings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if type is checkboxcell
            //if(dgvChooseSettings.CurrentCell.GetType() == DataGridViewCellTypes.
           // if(TypeOf (dgvChooseSettings.CurrentCell) Is DataGridViewCheckBoxCell)
                //set other check box cells to false
          //  if (dgvChooseSettings.CurrentCell.ColumnIndex != dgvChooseSettings.Rows.IndexOf(dgvChooseSettings.Rows["defaultS"]))
         //   {
            //    dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
          //  }


           /* if (dgvChooseSettings.CurrentCell.ColumnIndex != 0 && dgvChooseSettings.CurrentCell.Value != null && (bool)dgvChooseSettings.CurrentCell.Value == true)
            {
                // DataGridViewCheckBoxCell cell = dgvChooseSettings.CurrentCell;

                // if (cell.Value == true)
                // {
                if (dgvChooseSettings.CurrentCell.ReadOnly == true)
                {
                    return;
                }

                dgvChooseSettings.CurrentCell.ReadOnly = true;

                //  }
            }


            //if selected check box is "Default"
            if (dgvChooseSettings.CurrentCell.ColumnIndex == 1)
            {
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
            }

            //if selected check box is "Always Display"
            else if (dgvChooseSettings.CurrentCell.ColumnIndex == 2)
            {
                dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
            }

            //if selected check box is "Never Display"
            else if (dgvChooseSettings.CurrentCell.ColumnIndex == 3)
            {
                dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
            }*/
        }

        private void dgvChooseSettings_CurrentCellChanged(object sender, EventArgs e)
        {
           /* if (dgvChooseSettings.CurrentCell.ColumnIndex != 0 && dgvChooseSettings.CurrentCell.Value != null && (bool)dgvChooseSettings.CurrentCell.Value == true)
            {
                // DataGridViewCheckBoxCell cell = dgvChooseSettings.CurrentCell;

                // if (cell.Value == true)
                // {
                if (dgvChooseSettings.CurrentCell.ReadOnly == true)
                {
                    return;
                }

                dgvChooseSettings.CurrentCell.ReadOnly = true;
                
                //  }
            }


            //if selected check box is "Default"
            if (dgvChooseSettings.CurrentCell.ColumnIndex == 1)
            {
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
            }

            //if selected check box is "Always Display"
            else if (dgvChooseSettings.CurrentCell.ColumnIndex == 2)
            {
                dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
            }

            //if selected check box is "Never Display"
            else if (dgvChooseSettings.CurrentCell.ColumnIndex == 3)
            {
                dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
            }*/
        }

        private void dgvChooseSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChooseSettings.CurrentCell != null && dgvChooseSettings.CurrentCell.ColumnIndex != 0 && dgvChooseSettings.CurrentCell.Value != null && (bool)dgvChooseSettings.CurrentCell.Value == true)
            {
                // DataGridViewCheckBoxCell cell = dgvChooseSettings.CurrentCell;

                // if (cell.Value == true)
                // {
                if (dgvChooseSettings.CurrentCell.ReadOnly == true)
                {
                    return;
                }

                dgvChooseSettings.CurrentCell.ReadOnly = true;

                //  }



                //if selected check box is "Default"
                if (dgvChooseSettings.CurrentCell.ColumnIndex == 1)
                {
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
                }

                //if selected check box is "Always Display"
                else if (dgvChooseSettings.CurrentCell.ColumnIndex == 2)
                {
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
                }

                //if selected check box is "Never Display"
                else if (dgvChooseSettings.CurrentCell.ColumnIndex == 3)
                {
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
                }
            }
        }
    }
}

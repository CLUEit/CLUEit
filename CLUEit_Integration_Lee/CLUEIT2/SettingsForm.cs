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
        public SettingsForm(Preferences preferences_)
        {
            changedSettings = new Dictionary<string,settings>();
            preferences = preferences_;
            InitializeComponent();
            int index;
            //will pass in preferences colleciton
            foreach (Preference preference in preferences.preferenceList)
            {
                index = dgvChooseSettings.Rows.Add(preference.ServiceName);
                dgvChooseSettings.Rows[index].Cells["webService"].Value = preference.ServiceName;

                if(preference.Setting == settings.alwaysDisplay)
                {
                    dgvChooseSettings.Rows[index].Cells["alwaysDisplayS"].Value = true;
                    dgvChooseSettings.Rows[index].Cells["alwaysDisplayS"].ReadOnly = true;
                }

                 else if(preference.Setting == settings.neverDisplay)
                {
                    dgvChooseSettings.Rows[index].Cells["neverDisplayS"].Value = true;
                    dgvChooseSettings.Rows[index].Cells["neverDisplayS"].ReadOnly = true;
                }

                else
                {
                    dgvChooseSettings.Rows[index].Cells["defaultS"].Value = true;
                    dgvChooseSettings.Rows[index].Cells["defaultS"].ReadOnly = true;
                }
            }
        }

        private void dgvChooseSettings_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvChooseSettings.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
            if (dgvChooseSettings.CurrentCell != null && dgvChooseSettings.CurrentCell.ColumnIndex != 0 
                    && dgvChooseSettings.CurrentCell.Value != null && (bool)dgvChooseSettings.CurrentCell.Value == true
                    && e.RowIndex == dgvChooseSettings.CurrentCell.RowIndex && e.ColumnIndex == dgvChooseSettings.CurrentCell.ColumnIndex)
            {
                // DataGridViewCheckBoxCell cell = dgvChooseSettings.CurrentCell;

                // if (cell.Value == true)
              //   {
              //  if (dgvChooseSettings.CurrentCell.ReadOnly == true)
                //{
                  //  return;
                //}

                dgvChooseSettings.CurrentCell.ReadOnly = true;

                //  }



                //if selected check box is "Default"
                if (dgvChooseSettings.CurrentCell.ColumnIndex == 1)
                {
                    if(changedSettings.ContainsKey(dgvChooseSettings.CurrentRow.Cells["webService"].Value.ToString()))
                    {
                        changedSettings.Remove(dgvChooseSettings.CurrentRow.Cells["webService"].Value.ToString());
                       // changedSettings[dgvChooseSettings.CurrentRow.Cells["webService"].Value.ToString())] = settings.defaultDisplay;
                    }

                   // else
                  //  {
                        changedSettings.Add(dgvChooseSettings.CurrentRow.Cells["webService"].Value.ToString(), settings.defaultDisplay);
                   // }

                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
                }

                //if selected check box is "Always Display"
                else if (dgvChooseSettings.CurrentCell.ColumnIndex == 2)
                {
                    changedSettings.Add(dgvChooseSettings.CurrentRow.Cells["webService"].Value.ToString(), settings.alwaysDisplay);
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["neverDisplayS"].ReadOnly = false;
                }

                //if selected check box is "Never Display"
                else if (dgvChooseSettings.CurrentCell.ColumnIndex == 3)
                {
                    changedSettings.Add(dgvChooseSettings.CurrentRow.Cells["webService"].Value.ToString(), settings.neverDisplay);
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["defaultS"].ReadOnly = false;
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].Value = false;
                    dgvChooseSettings.CurrentRow.Cells["alwaysDisplayS"].ReadOnly = false;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (var s in changedSettings)
            {
                preferences.UpdatePreference(s.Key, s.Value);
            }

            this.Close();
        }

        Preferences preferences;
        Dictionary<string, settings> changedSettings;
    }
}

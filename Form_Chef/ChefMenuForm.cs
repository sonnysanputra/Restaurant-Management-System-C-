using Assignment;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ChefMenuForm : Form
    {
        private MenuItem _menuItemObj;
        private MenuItem _selectedMenuItem;

        public ChefMenuForm()
        {
            InitializeComponent();
            _menuItemObj = new MenuItem();
            LoadMenuItems();

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            rdoBtnAdd.CheckedChanged += rdoBtnAdd_CheckedChanged_1;
            rdoBtnRemove.CheckedChanged += rdoBtnRemove_CheckedChanged_1;
            rdoBtnUpdate.CheckedChanged += rdoBtnUpdate_CheckedChanged;

            rdoBtnAdd.Checked = true;
            SetAddMode();

            feedbackTimer.Interval = 3000;
            feedbackTimer.Tick += feedbackTimer_Tick;

            lblFeedback.Visible = false;
            picTick.Visible = false;
        }


        //This method is to load all the items from the MenuItem table in the db and populate the listbox
        private void LoadMenuItems()
        {
            try
            {
                var menuItems = _menuItemObj.GetAllMenuItems();

                lstMenuList.Items.Clear();

                foreach (var item in menuItems)
                {
                    lstMenuList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                ShowFeedback($"Error loading menu items: {ex.Message}", Color.Red, false);
            }
        }

        //This Method is used to empty the textboxes in the UI
        private void ClearAddMenuItemControls()
        {
            txtDishName.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            chckAvailable.Checked = false;
            _selectedMenuItem = null;
        }

        private void SetAddMode()
        {
            ClearAddMenuItemControls();

            txtDishName.Enabled = true;
            cmbCategory.Enabled = true;
            txtPrice.Enabled = true;
            chckAvailable.Enabled = true;

            lstMenuList.Enabled = false;
            btnConfirm.Enabled = true;

            _selectedMenuItem = null;
            lstMenuList.ClearSelected();
        }

        //Method for remove radio button
        private void SetRemoveMode()
        {
            ClearAddMenuItemControls();

            txtDishName.Enabled = false;
            cmbCategory.Enabled = true;
            txtPrice.Enabled = false;
            chckAvailable.Enabled = false;

            lstMenuList.Enabled = true;
            btnConfirm.Enabled = true;

            _selectedMenuItem = null;
            lstMenuList.ClearSelected();
        }

        //Method for Update radio button
        private void SetUpdateMode()
        {
            ClearAddMenuItemControls();

            txtDishName.Enabled = false; 
            cmbCategory.Enabled = true;
            txtPrice.Enabled = false;
            chckAvailable.Enabled = false;

            lstMenuList.Enabled = true;
            btnConfirm.Enabled = true;

            _selectedMenuItem = null;
            lstMenuList.ClearSelected();
        }


        private void rdoBtnAdd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoBtnAdd.Checked)
            {
                SetAddMode();
            }
        }

        private void rdoBtnRemove_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoBtnRemove.Checked)
            {
                SetRemoveMode();
            }
        }


        private void rdoBtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnUpdate.Checked)
            {
                SetUpdateMode();
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rdoBtnAdd.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDishName.Text) || cmbCategory.SelectedItem == null || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    ShowFeedback("Please do not leave any required fields empty.", Color.Red, false);
                    return;
                }

                if (_menuItemObj.GetAllMenuItems().Any(m => m.Name.Equals(txtDishName.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    ShowFeedback("A dish with the same name already exists.", Color.Red, false);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    ShowFeedback("Please enter a valid price.", Color.Red, false);
                    return;
                }

                var newMenuItem = new MenuItem
                {
                    Name = txtDishName.Text,
                    Category = cmbCategory.SelectedItem?.ToString() ??"",
                    Price = price,
                    IsAvailable = chckAvailable.Checked
                };

                try
                {
                    _menuItemObj.AddMenuItem(newMenuItem);
                    LoadMenuItems();
                    ClearAddMenuItemControls();
                    _selectedMenuItem = null;

                    rdoBtnAdd.Checked = true;
                    SetAddMode();

                    ShowFeedback("Menu item has been added.", Color.Green, true);
                }
                catch (Exception ex)
                {
                    ShowFeedback($"Error adding menu item: {ex.Message}", Color.Red, false);
                }
            }

            else if (rdoBtnRemove.Checked)
            {
                if (_selectedMenuItem == null)
                {
                    ShowFeedback("Please select a menu item to remove", Color.Red, false);
                    return;
                }

                try
                {
                    _menuItemObj.DeleteMenuItem(_selectedMenuItem.MenuItemID);
                    LoadMenuItems();
                    ClearAddMenuItemControls();
                    lstMenuList.ClearSelected();
                    ShowFeedback("Menu item has been removed.", Color.Green, true);
                }
                catch (Exception ex)
                {
                    ShowFeedback($"Error in removing menu item: {ex.Message}", Color.Red, false);
                }
            }

            else if (rdoBtnUpdate.Checked)
            {
                if (_selectedMenuItem == null)
                {
                    ShowFeedback("Please select a menu item to update", Color.Red, false);
                    return;
                }

                if (_menuItemObj.GetAllMenuItems() .Any(m => m.MenuItemID != _selectedMenuItem.MenuItemID && m.Name.Equals(txtDishName.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    ShowFeedback("Another dish with the same name already exists.", Color.Red, false);
                    return;
                }

                if (string.IsNullOrEmpty(txtDishName.Text) || cmbCategory.SelectedItem == null || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    ShowFeedback("Please do not leave any required fields empty.", Color.Red, false);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    ShowFeedback("Please enter a valid price.", Color.Red, false);
                    return;
                }

                _selectedMenuItem.Name = txtDishName.Text;
                _selectedMenuItem.Category = cmbCategory.SelectedItem?.ToString() ?? "";
                _selectedMenuItem.Price = price;
                _selectedMenuItem.IsAvailable = chckAvailable.Checked;

                try
                {
                    _menuItemObj.UpdateMenuItem(_selectedMenuItem);
                    LoadMenuItems();
                    ClearAddMenuItemControls();
                    ShowFeedback("Menu item updated successfully.", Color.Green, true);
                }
                catch(Exception ex)
                {
                    ShowFeedback($"Error in updating menu item: {ex.Message}", Color.Red, false);
                }
            }


        }

        private void lstMenuList_SelectedIndexChanged(object sender, EventArgs e) 
        {
        if (lstMenuList.SelectedIndex >= 0)
            {
                _selectedMenuItem = (MenuItem)lstMenuList.SelectedItem;

                txtDishName.Text = _selectedMenuItem.Name;
                cmbCategory.SelectedItem = _selectedMenuItem.Category;
                txtPrice.Text = _selectedMenuItem.Price.ToString("0.00");
                chckAvailable.Checked = _selectedMenuItem.IsAvailable;

                if (rdoBtnUpdate.Checked)
                {
                    txtDishName.Enabled = true;
                    cmbCategory.Enabled = true;
                    txtPrice.Enabled = true;
                    chckAvailable.Enabled = true;
                }
            }

            else
            {
                ClearAddMenuItemControls();
            }
        }

        private void ShowFeedback(string message, Color color, bool showTick)
        {
            lblFeedback.Text = message;
            lblFeedback.ForeColor = color;
            picTick.Visible = showTick;
            lblFeedback.Visible = true;
            feedbackTimer.Start();
        }

        private void feedbackTimer_Tick(object sender, EventArgs e)
        {
            lblFeedback.Text = string.Empty;
            picTick.Visible = false;
            lblFeedback.Visible = false;
            feedbackTimer.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

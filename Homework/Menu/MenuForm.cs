using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class MenuForm : Form
    {
        private OrderForm _orderForm;
        private InventoryForm _inventoryForm;
        private ProductManagementForm _productManagementForm;
        private OrderFormPresentationModel _orderFormPresentationModel;
        private InventoryFormPresentationModel _inventoryFormPresentationModel;
        private ProductManagementPresentationModel _productManagementPresentationModel;
        public MenuForm(OrderFormPresentationModel orderFormPresentationModel, InventoryFormPresentationModel inventoryFormPresentationModel, ProductManagementPresentationModel productManagementPresentationModel)
        {
            InitializeComponent();
            _orderSystemButton.Click += ClickOrderSystemButton;
            _inventorySystemButton.Click += ClickInventorySystemButton;
            _productManageSystemButton.Click += ClickProductManageSystemButton;
            _exitButton.Click += ClickExitButton;
            _orderFormPresentationModel = orderFormPresentationModel;
            _inventoryFormPresentationModel = inventoryFormPresentationModel;
            _productManagementPresentationModel = productManagementPresentationModel;
            _inventoryForm = new InventoryForm(_inventoryFormPresentationModel);
            _orderForm = new OrderForm(_orderFormPresentationModel);
            _productManagementForm = new ProductManagementForm(_productManagementPresentationModel);
            _inventoryForm.FormClosing += HandleInventoryFormFormClosing;
            _orderForm.FormClosing += HandleOrderFormFormClosing;
            _productManagementForm.FormClosing += HandleProductManagementFormFormClosing;
        }
        // InventoryForm 關閉前前的事件
        private void HandleInventoryFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
            _inventorySystemButton.Enabled = !_inventorySystemButton.Enabled;
        }

        // OrderForm 關閉前前的事件 
        private void HandleOrderFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
            _orderSystemButton.Enabled = !_orderSystemButton.Enabled;
        }

        // ProductManagementForm 關閉前前的事件
        private void HandleProductManagementFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
            _productManageSystemButton.Enabled = !_productManageSystemButton.Enabled;
        }

        // Order System Start
        private void ClickOrderSystemButton(Object sender, EventArgs e)
        {
            _orderSystemButton.Enabled = false;
            _orderForm.Show();
        }

        // Inventory System Start
        private void ClickInventorySystemButton(Object sender, EventArgs e)
        {
            _inventorySystemButton.Enabled = false;
            _inventoryForm.Show();
        }

        // Product Manage System Start
        private void ClickProductManageSystemButton(Object sender, EventArgs e)
        {
            _productManageSystemButton.Enabled = false;
            _productManagementForm.Show();
        }
        
        //  close system
        private void ClickExitButton(Object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}

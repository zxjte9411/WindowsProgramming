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
        private OrderFormPresentationModel _orderFormPresentationModel;
        public MenuForm(OrderFormPresentationModel orderFormPresentationModel)
        {
            InitializeComponent();
            _orderSystemButton.Click += ClickOrderSystemButton;
            _inventorySystemButton.Click += ClickInventorySystemButton;
            _exitButton.Click += ClickExitButton;
            _orderFormPresentationModel = orderFormPresentationModel;
        }

        // Order System Start
        private void ClickOrderSystemButton(Object sender, EventArgs e)
        {
            _orderSystemButton.Enabled = false;
            _orderForm = new OrderForm(_orderFormPresentationModel);
            _orderForm.FormClosed += HandleOrderFormCloseUpClick;
            _orderForm.Show();
        }

        // Inventory System Start
        private void ClickInventorySystemButton(Object sender, EventArgs e)
        {
            _inventorySystemButton.Enabled = false;
            _inventoryForm = new InventoryForm();
            _inventoryForm.FormClosed += HandleInventoryFormCloseUpClick;
            _inventoryForm.Show();
        }

        //  close system
        private void ClickExitButton(Object sender, EventArgs e)
        {
            Close();
        }

        // Order Form close handle
        private void HandleOrderFormCloseUpClick(Object sender, EventArgs e)
        {
            _orderSystemButton.Enabled = true;
        }

        // Inventory Form close handle
        private void HandleInventoryFormCloseUpClick(Object sender, EventArgs e)
        {
            _inventorySystemButton.Enabled = true;
        }
    }
}

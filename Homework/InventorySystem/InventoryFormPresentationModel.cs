using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class InventoryFormPresentationModel
    {
        public delegate void DataGridViewEventHandler(int rowIndex);
        public event DataGridViewEventHandler _selectCellEvent;
        public event DataGridViewEventHandler _replacementEvent;
        private Model _model;
        public InventoryFormPresentationModel(Model model)
        {
            _model = model;
        }

        public Model Model
        {
            get
            {
                return _model;
            }
        }

        // 處理DataGridView的程序
        public void HandleDataGridViewPerformance(int rowIndex, int columnIndex)
        {
            if (columnIndex == 0 && rowIndex >= 0)
            {
                if (_selectCellEvent != null)
                    _selectCellEvent(rowIndex);
            }                    
            else if (columnIndex == Constant.FOUR && rowIndex >= 0)
            {
                if (_replacementEvent != null)
                    _replacementEvent(rowIndex);
            }
        }

        // 取得產品整理過的 row data
        public string[] GetRowData(Product product)
        {
            string[] result = new string[Constant.FOUR];
            result[0] = product.Name;
            result[1] = product.Category.Name;
            result[Constant.TWO] = int.Parse(product.Price).ToString(Constant.NO);
            result[Constant.THREE] = product.Quantity;
            return result;
        }
    }
}

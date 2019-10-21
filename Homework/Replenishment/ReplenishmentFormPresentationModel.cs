using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ReplacementFormPresentationModel
    {
        private Model _model;
        public ReplacementFormPresentationModel(Model model)
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

        // 處理庫存數量變更(增加)
        public void HandleStockQuantityChange(int index, string value)
        {
            _model.IncreaseStockProductQuantity(index, value);
        }
    }
}

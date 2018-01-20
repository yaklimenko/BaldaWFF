using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Balda
{
    public class BaldaFieldButton : Button
    {
        public char Value
        {
            get { return val; }
            set {
                val = value;
                base.Text = val.ToString();
            }
        }
        private char val = ' ';
        public int indexX = 0;
        public int indexY = 0;

        private BaldaCheatingForm _parentFormInstance;
        private BaldaCheatingForm _parentForm
        {
            get { return _parentFormInstance ?? (_parentFormInstance = this.FindForm() as BaldaCheatingForm); }
        }

        public void Highlight()
        {
            ForeColor = _parentForm.HlForeColor;
        }

        public void HighLighter()
        {
            BackColor = _parentForm.HlBackColor;
        }

        public void Unlight()
        {
            ForeColor = _parentForm.defaultForeColor;
            BackColor = _parentForm.defaultBackColor;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (_parentForm.IsEditMode)
            {
                _parentForm.UnlightField();
                _parentForm.ButtonToEdit = this;
                BackColor = _parentForm.EditBackColor;
                ForeColor = _parentForm.EditForeColor;
            }
        }
    }
}

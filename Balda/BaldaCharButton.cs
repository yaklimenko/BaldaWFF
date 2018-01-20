using System;
using System.Windows.Forms;

namespace Balda
{
    class BaldaCharButton : Button
    {
        private BaldaCheatingForm _parentFormInstance;
        private BaldaCheatingForm ParentForm
        {
            get { return _parentFormInstance ?? (_parentFormInstance = FindForm() as BaldaCheatingForm); }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (!ParentForm.IsEditMode || ParentForm.ButtonToEdit == null) return;
            ParentForm.ButtonToEdit.Value = Text[0];
            ParentForm.ButtonToEdit.Unlight();
            ParentForm.RefreshPlayFieldChars();
            ParentForm.ButtonToEdit = null;
        }
    }
}

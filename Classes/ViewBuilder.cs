using CodeGenerator.Templates.UI.Views;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CodeGenerator.Classes
{
    public class ViewBuilder
    {
        private const string VIEW_EXTENSION = ".cshtml";

        public void AddCreateView(CheckBox chkbx, string fullPath, Arguments arguments)
        {
            if (chkbx.Checked)
            {
                var template = new CreateView(arguments);
                var fileName = "Create" + VIEW_EXTENSION;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }
        }

        public void AddDetailsView(CheckBox chkbx, string fullPath, Arguments arguments)
        {
            if (chkbx.Checked)
            {
                var template = new DetailsView(arguments);
                var fileName = "Details" + VIEW_EXTENSION;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }
        }

        public void AddEditView(CheckBox chkbx, string fullPath, Arguments arguments)
        {
            if (chkbx.Checked)
            {
                var template = new EditView(arguments);
                var fileName = "Edit" + VIEW_EXTENSION;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }
        }

        public void AddListView(CheckBox chkbx, string fullPath, Arguments arguments)
        {
            if (chkbx.Checked)
            {
                var template = new Templates.UI.Views.ListView(arguments);
                var fileName = "Index" + VIEW_EXTENSION;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }
        }

        public void AddSpecificView(List<CheckBox> chkbxs, string fullPath, Arguments arguments)
        {
            if (!chkbxs[0].Checked && !chkbxs[1].Checked && !chkbxs[2].Checked && !chkbxs[3].Checked)
            {
                var template = new Templates.UI.Views.View(arguments);
                var fileName = arguments.VerticleName + VIEW_EXTENSION;
                File.WriteAllText(fullPath + fileName, template.TransformText());
            }
        }
    }
}

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingUI_5_2
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Сообщение", "Выберите стены, у которых хотите изменить тип. После выбора нажмите Finish");

            var window = new MainView(commandData);
            window.ShowDialog();
            return Result.Succeeded;
        }
    }
}

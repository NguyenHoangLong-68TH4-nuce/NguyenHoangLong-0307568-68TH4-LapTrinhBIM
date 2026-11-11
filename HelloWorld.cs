using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace HelloWorld
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elementSet)
        {
            TaskDialog.Show("Hello", "Hello World");
            return Result.Succeeded;
        }
    }
}

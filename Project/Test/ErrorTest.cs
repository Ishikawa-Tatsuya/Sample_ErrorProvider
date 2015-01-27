using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using System.Diagnostics;
using System.Windows.Forms;
using Ong.Friendly.FormsStandardControls;

namespace Test
{
    [TestClass]
    public class ErrorTest
    {
        WindowsAppFriend _app;
        dynamic _form;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start("WindowsFormsApplication.exe"));
            _form = _app.Type<Application>().OpenForms[0];
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).CloseMainWindow();
        }

        [TestMethod]
        public void Test()
        {
            var textBox = new FormsTextBox(_form._textBox);
            var button = new FormsButton(_form._button);
            textBox.EmulateChangeText("abc");
            button.SetFocus();

            string err = _form._errorProvider.GetError(_form._textBox);
            Assert.AreEqual("数字じゃないよ。", err);
        }
    }
}

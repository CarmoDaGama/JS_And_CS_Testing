var edge = require("edge-js");
var myDll = ".\\src\\WindowsFormsApp1\\bin\\Debug\\WindowsFormsApp1.exe";
var showForm = edge.func({
  assemblyFile: myDll, // path to .dll
  typeName: "WindowsFormsApp1.EdgeJsMethods.Methods",
  methodName: "ShowForm",
});

showForm(
  { name: "Carmo Da Gama", email: "gama@carmodagama.com", age: 25 },
  function (error, result) {
    if (error) throw error;
    console.log(result);
  }
);

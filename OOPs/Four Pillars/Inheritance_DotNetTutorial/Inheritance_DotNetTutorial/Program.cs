using Inheritance_DotNetTutorial;

B b = new B();

// Public fields and Members of Parent class accessible in child class.

var a = b.publicFieldofA;
//var b = b.privateFieldofA;  // As it is a private field of parent class so not accessible, throws error.
var c = b.publicFieldofB;

b.publicMethodofA();
//b.privateMethodofA();    // As it is a private member of parent class so not accessible, throws error.
b.publicMethodofB();

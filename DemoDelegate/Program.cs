ReferenciaMetodoVoid ref1 = UmaClasseQualquer.MetodoQualquerStatic;
ref1();

var obj = new UmaClasseQualquer();
ReferenciaMetodoVoid ref2 = obj.MetodoQualquer;
ref2();

ReferenciaMetodoVoid ref3 = () => Console.WriteLine("ExpressaoLambda");
ref3();

Action ref4 = UmaClasseQualquer.MetodoQualquerStatic;

var resultado = UmaClasseQualquer.FazUmCalculo(3, (a,b) => a*b);
Console.WriteLine(resultado);

var ref5 = UmaClasseQualquer.ConstroiMetodo(7);
Console.WriteLine(ref5(3));
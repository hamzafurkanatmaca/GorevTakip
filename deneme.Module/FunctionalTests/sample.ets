;#DropDB denemeEasyTest

#Application deneme.Win
#Application deneme.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef deneme.Win

*Action About...
 
*Action OK

#EndIf

#IfDef deneme.Web
*Action Navigation(My Details)
#EndIf

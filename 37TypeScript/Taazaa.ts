class Taazaa
{
    EmpName:string;// instance variable
    EmpAge:Number;
    constructor(EN:string,EAge:Number)
    {
        this.EmpName=EN;
        this.EmpAge=EAge;
    }
    FetchData():void
    {
        console.log(this.EmpAge,this.EmpName);
    }
}
var obj=new Taazaa('lucky',22);
obj.FetchData();
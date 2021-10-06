try{  
    var a=2;  
    if(a==2)  
    console.log("ok");  
    }  
    catch(Error){  
    console.log("Error found"+e.message);  
    }  
    finally{  
   console.log ("Value of a is 2 ");  
    } 
    
//----------------------------------------------------------------------------------------------------------------------------
// 2nd method 
var a=10;
var b=20;
var c=0;
try {
    function plus()
    {
        console.log("\n plus= "+a+b+c);
    }
    function minus()
    {
        console.log("\n minus= "+(a+b-c));
    }
    function multiply()
    {
        console.log("\n multiply= "+a*b*c);
    }
    function divide()
    {
        if(c!=0)
        {
            console.log("\n Divide= "+(a+b)/c);
        }
        else
        {
            throw "\n can/t divide with 0";
        }
    }
    plus();
    minus();
    multiply();
    divide();
} 
catch (error) {
    console.log(error);
    c=2;
    divide();
}
finally
{
    console.log("\n Program execution Handled Successfully !!!! \n");
}
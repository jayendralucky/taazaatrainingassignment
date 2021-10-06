//Clouser:- it is a inner class or inner function that can access variable declared out side of the inner class or the outer class .it is used to hide the implementation of the function or the class
function plus(a,b)
{
    a+=1;
    b+=1;
    var c=a+b;
    function incrementorPlus()
    {
        c+=1;
        return c;
    }
    c=incrementorPlus();
    console.log(c);
}
plus(10,20);
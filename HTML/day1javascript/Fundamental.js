function Walk(x)   //called
{
    var arr = new Array(10, 20, 30, 40, 50, 60, 70);
    console.log(arr[0]);
    var arr2=["java","is","new"]
    var result  = '';
    for(var i = 0;i<arr.length;i++)
    {
        result = result +" "+ arr[i];
    }
    arr=arr.reverse();//reverse of array
    console.log(arr);
    var result1=arr.concat(arr2);
    console.log(result1)
    console.log(result);
    var j=0;
    var b="lucky";
    var c=""
    for(var j=b.length-1;j>=0;j--)
    {
        c+=b[j]
    }
    console.log(c);
    var a=b.split("");
    console.log(a);
    var x= arr.copyWithin(0,1,2);
    console.log(x);
    var i=arr.join('-')
    console.log(i);
    var itr=arr.entries();
    for(var e of itr)
    {
        console.log(e);
    }
    function check(value)
    {
        return value>20;
    }
    console.log(arr.every(check));
}
Walk();  //caller
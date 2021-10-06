class Mobile
{
    constructor(name,price)
    {
        this.name=name;
        this.price=price;
    }
    printName()
    {
        console.log(this.name);
    }
    printPrice()
    {
        console.log(this.price);
    }
}
class Phonetype extends Mobile
{
    constructor(touch,name,price)
    {
        super(name,price)
        this.touch=touch;
    }
    printtouchtype()
    {
        console.log(this.touch);
    }
}
var androidphone = new Phonetype(1.5,'samsung',80000);
androidphone.printName();
androidphone.printPrice();
androidphone.printtouchtype();

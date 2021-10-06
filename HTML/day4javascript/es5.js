function Person(name)
{
    this.name=name;
}
Person.prototype.getname = function()
{
    return this.name;
};

var lucky = new Person("lucky singh")
console.log(lucky.getname());
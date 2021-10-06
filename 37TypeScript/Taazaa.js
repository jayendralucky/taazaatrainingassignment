var Taazaa = /** @class */ (function () {
    function Taazaa(EN, EAge) {
        this.EmpName = EN;
        this.EmpAge = EAge;
    }
    Taazaa.prototype.FetchData = function () {
        console.log(this.EmpAge, this.EmpName);
    };
    return Taazaa;
}());
var obj = new Taazaa('lucky', 22);
obj.FetchData();

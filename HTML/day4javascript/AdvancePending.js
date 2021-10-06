"use strict";
exports.__esModule = true;
exports.Tazzaa = void 0;
var Tazzaa = /** @class */ (function () {
    function Tazzaa(tax) {
        console.log(tax);
        this.t = tax;
    }
    Tazzaa.prototype.gettax = function () {
        return this.t;
    };
    return Tazzaa;
}());
exports.Tazzaa = Tazzaa;

"use strict";
class ASecurity {
    constructor() {
        console.log("ASecurity nesnesi olusturuldu");
    }
}
class BSecurity {
    constructor() {
        console.log("BSecurity nesnesi olusturuldu");
    }
}
class CSecurity {
    constructor() {
        console.log("CSecurity nesnesi olusturuldu");
    }
}
class ASecurityFactory {
    createInstance() {
        return new ASecurity();
    }
}
class BSecurityFactory {
    createInstance() {
        return new BSecurity();
    }
}
class CSecurityFactory {
    createInstance() {
        return new CSecurity();
    }
}
class SecurityCreator {
    static create(securityType) {
        let securityFactory = null;
        switch (securityType) {
            case SecurityType.A:
                securityFactory = new ASecurityFactory();
                break;
            case SecurityType.B:
                securityFactory = new BSecurityFactory();
                break;
            case SecurityType.C:
                securityFactory = new CSecurityFactory();
                break;
        }
        return securityFactory.createInstance();
    }
}
var SecurityType;
(function (SecurityType) {
    SecurityType[SecurityType["A"] = 0] = "A";
    SecurityType[SecurityType["B"] = 1] = "B";
    SecurityType[SecurityType["C"] = 2] = "C";
})(SecurityType || (SecurityType = {}));
const a1 = SecurityCreator.create(SecurityType.A);
const b1 = SecurityCreator.create(SecurityType.B);
const c1 = SecurityCreator.create(SecurityType.C);
//# sourceMappingURL=app.js.map
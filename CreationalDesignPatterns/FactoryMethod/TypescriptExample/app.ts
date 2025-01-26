
interface ISecurity {

}

class ASecurity implements ISecurity {
    constructor() {
        console.log("ASecurity nesnesi olusturuldu");
    }
}

class BSecurity implements ISecurity {
    constructor() {
        console.log("BSecurity nesnesi olusturuldu");
    }
}

class CSecurity implements ISecurity {
    constructor() {
        console.log("CSecurity nesnesi olusturuldu");
    }
}

interface ISecurityFactory {
    createInstance(): ISecurity;
}

class ASecurityFactory implements ISecurityFactory {
    createInstance(): ISecurity {
        return new ASecurity();
    }
}

class BSecurityFactory implements ISecurityFactory {
    createInstance(): ISecurity {
        return new BSecurity();
    }
}

class CSecurityFactory implements ISecurityFactory {
    createInstance(): ISecurity {
        return new CSecurity();
    }
}

class SecurityCreator{
    static create(securityType: SecurityType): ISecurity {

        let securityFactory: ISecurityFactory | null = null;

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

enum SecurityType {
    A, B, C
}

const a1 = SecurityCreator.create(SecurityType.A);
const b1 = SecurityCreator.create(SecurityType.B);
const c1 = SecurityCreator.create(SecurityType.C);
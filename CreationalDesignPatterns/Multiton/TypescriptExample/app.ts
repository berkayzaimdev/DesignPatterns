class MailService {
    private constructor() {
        console.log("nesne olusturuldu!");
    }

    static mailServices: { [key: string]: MailService } = {}
    static getInstance(key: string) {
        if (this.mailServices[key] == null) {
            this.mailServices[key] = new MailService();
        }

        const mailService = this.mailServices[key];
        return this.mailServices[key];
    }

    private _mail: string | undefined;
    get mail(): string {
        return this._mail === undefined ? "" : this._mail;
    }
    set mail(value: string) {
        this._mail = value;
    }

    private _userName: string | undefined;
    get userName(): string {
        return this._userName === undefined ? "" : this._userName;
    }
    set userName(value: string) {
        this._userName = value;
    }

    private _password: string | undefined;
    get password(): string {
        return this._password === undefined ? "" : this._password;
    }
    set password(value: string) {
        this._password = value;
    }
}

const gmail: MailService = MailService.getInstance("gmail");
const outlook: MailService = MailService.getInstance("outlook");
const yandex: MailService = MailService.getInstance("yandex");

gmail.mail = "...";
gmail.userName = "...";
gmail.password = "...";

outlook.mail = "...";
outlook.userName = "...";
outlook.password = "...";

const gmail2: MailService = MailService.getInstance("gmail");
const outlook2: MailService = MailService.getInstance("outlook");

gmail2.mail = "...";
gmail2.userName = "...";
gmail2.password = "...";

outlook2.mail = "...";
outlook2.userName = "...";
outlook2.password = "...";
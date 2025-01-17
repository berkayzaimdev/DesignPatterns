"use strict";
class MailService {
    constructor() {
        console.log("nesne olusturuldu!");
    }
    static getInstance(key) {
        if (this.mailServices[key] == null) {
            this.mailServices[key] = new MailService();
        }
        const mailService = this.mailServices[key];
        return this.mailServices[key];
    }
    get mail() {
        return this._mail === undefined ? "" : this._mail;
    }
    set mail(value) {
        this._mail = value;
    }
    get userName() {
        return this._userName === undefined ? "" : this._userName;
    }
    set userName(value) {
        this._userName = value;
    }
    get password() {
        return this._password === undefined ? "" : this._password;
    }
    set password(value) {
        this._password = value;
    }
}
MailService.mailServices = {};
const gmail = MailService.getInstance("gmail");
const outlook = MailService.getInstance("outlook");
const yandex = MailService.getInstance("yandex");
gmail.mail = "...";
gmail.userName = "...";
gmail.password = "...";
outlook.mail = "...";
outlook.userName = "...";
outlook.password = "...";
const gmail2 = MailService.getInstance("gmail");
const outlook2 = MailService.getInstance("outlook");
gmail2.mail = "...";
gmail2.userName = "...";
gmail2.password = "...";
outlook2.mail = "...";
outlook2.userName = "...";
outlook2.password = "...";
//# sourceMappingURL=app.js.map
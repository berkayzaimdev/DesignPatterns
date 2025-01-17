"use strict";
class Database {
    constructor() {
        this.count = 1;
        console.log("Nesne �retildi!");
    }
    static get getInstance() {
        if (this._database == null) {
            this._database = new Database();
        }
        return this._database;
    }
    connection() {
        console.log("Connected");
        console.log(this.count++);
    }
}
let d1 = Database.getInstance;
d1.connection();
let d2 = Database.getInstance;
d2.connection();
let d3 = Database.getInstance;
d3.connection();
let d4 = Database.getInstance;
d4.connection();
//# sourceMappingURL=app.js.map
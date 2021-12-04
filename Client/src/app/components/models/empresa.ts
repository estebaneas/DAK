export class empresa {
    razon_social: string;
    rut: string;
    constructor(obj: any) {
        this.razon_social = obj.razonSocial;
        this.rut = obj.rut;
    }
}
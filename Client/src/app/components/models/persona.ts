export class persona {
    nombre: string;
    apellido: string;
    documento: string;
    constructor(obj: any) {
        this.nombre = obj.nombre;
        this.apellido = obj.apellido;
        this.documento = obj.nombre;
    }
}
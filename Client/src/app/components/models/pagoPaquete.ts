export class pagoPaquete {
    numero: number;
    monto: number;
    fechaDepago: Date;
    montoFinal: number;
    tipoPago: number;
    constructor(obj: any) {
        this.numero = obj.numero;
        this.monto = obj.monto;
        this.fechaDepago = obj.fechaDepago;
        this.montoFinal = obj.montoFinal;
        this.tipoPago = obj.tipoPago;
    }
}
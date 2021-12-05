export class pagoPaquete {
    Numero: number;
    Monto: number;
    FechaDepago: Date;
    MontoFinal: number;
    TipoPago: number;
    constructor(obj: any) {
        this.Numero = obj.Numero;
        this.Monto = obj.Monto;
        this.FechaDepago = obj.FechaDepago;
        this.MontoFinal = obj.MontoFinal;
        this.TipoPago = obj.TipoPago;
    }
}
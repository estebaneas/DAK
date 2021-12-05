import { empresa } from "./empresa";
import { persona } from "./persona";

export class cliente {
    telefono: string;
    localidad: string;
    calle: string;
    detalle_direccion: string;
    email: string;
    id_condado: number;
    grupo: number;
    tipo_documento: number;
    documento: string;
    persona: persona;
    empresa: empresa;

    constructor(obj: any) {
        this.telefono = obj.telefono;
        this.localidad = obj.localidad;
        this.calle = obj.calle;
        this.detalle_direccion = obj.detalle;
        this.email = obj.email;
        this.id_condado = obj.condado;
        this.grupo = obj.grupo;
        this.tipo_documento = obj.tipo_documento;
        this.documento = obj.documento;
        this.persona = obj.persona;
        this.empresa = obj.empresa;
    }
}




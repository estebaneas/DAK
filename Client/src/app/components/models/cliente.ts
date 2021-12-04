export interface paquete {
    remitente: string,
    destinatario: string,
    calle: string,
    condado: string,
    distancia: number,
    localidad: string,
    detalle: string,
    peso: number
}

export interface persona {
    nombre: string,
    apellido: string,
    documento: string,
}

export interface empresa {
    razonSocial: string,
    rut: string,
}
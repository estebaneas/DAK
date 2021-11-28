using CommonSolution.Dtos;
using FluentValidation;

namespace Api.Validator.Paquete
{
    public class PaqueteResourceValidator : AbstractValidator<PaqueteDto>
    {
        public PaqueteResourceValidator()
        {
            RuleFor(r => r.ID)
             .Empty()
             .WithMessage("ID debe estar vacio");
            RuleFor(r => r.Estado)
             .Empty()
             .WithMessage("Estado debe estar vacio");
            RuleFor(r => r.Peso)
             .NotEmpty()
             .WithMessage("Peso no puede estar vacio");
            RuleFor(r => r.Peso)
             .GreaterThan(0)
             .WithMessage("Peso tiene que ser mayor a 0");
            RuleFor(r => r.FechaRecibido)
             .NotNull()
             .WithMessage("Fecha Recibido no puede estar vacio");
            RuleFor(r => r.FechaEnviado)
             .NotNull()
             .WithMessage("Fecha Enviado no puede estar vacio");
            RuleFor(r => r.Calle)
             .NotEmpty()
             .WithMessage("Calle no puede estar vacio");
            RuleFor(r => r.Localidad)
             .NotEmpty()
             .WithMessage("Localidad no puede estar vacio");
            RuleFor(r => r.DocumentoRemitente)
             .NotEmpty()
             .WithMessage("Documento Remitente no puede estar vacio");
            RuleFor(r => r.DocumentoRemitente)
             .NotEqual(r => r.DocumentoDestinatario)
             .WithMessage("Documento Remitente no puede ser igual a Documento Destinatario no puede estar vacio");
            RuleFor(r => r.DocumentoDestinatario)
             .NotEmpty()
             .WithMessage("Documento Destinatario no puede estar vacio");
            RuleFor(r => r.DocumentoDestinatario)
             .NotEqual(r=> r.DocumentoRemitente)
             .WithMessage("Documento Destinatario no puede ser igual a Documento Remitente no puede estar vacio");
            RuleFor(r => r.ID_Zona)
             .NotEmpty()
             .WithMessage("ID Zona no puede estar vacio");
            RuleFor(r => r.ID_Condado)
             .NotEmpty()
             .WithMessage("ID Condado no puede estar vacio");
            RuleFor(r => r.Numero_Factura)
             .NotEmpty()
             .WithMessage("Numero de Factura no puede estar vacio");
            RuleFor(r => r.Tamano)
             .NotEmpty()
             .WithMessage("Tamano no puede estar vacio");
        }
    }
}
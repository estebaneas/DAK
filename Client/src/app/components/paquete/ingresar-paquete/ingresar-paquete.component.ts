import { Component} from '@angular/core';
import { CondadoService } from 'src/app/services/dak/condado/condado.service';

@Component({
  selector: 'app-ingresar-paquete',
  templateUrl: './ingresar-paquete.component.html',
  styleUrls: ['./ingresar-paquete.component.css']
})
export class IngresarPaqueteComponent{

  condados: any[] = [];
  loading: boolean = true;

  constructor(private condadoService: CondadoService) {
    this.condadoService.getCondadoList()
    .subscribe((data: any) => {
      console.log(data);
      this.condados = data;
      this.loading = false;
    });
   }


}

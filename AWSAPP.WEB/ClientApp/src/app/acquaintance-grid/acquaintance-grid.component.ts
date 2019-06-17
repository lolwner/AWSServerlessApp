import { Component, OnInit } from '@angular/core';
import { AcquaintanceService } from '../core/services/acquaintance.service';
import { AcquaintanceResponseModel } from '../core/models/acquaintance-response-model';

@Component({
  selector: 'app-acquaintance-grid',
  templateUrl: './acquaintance-grid.component.html',
  styleUrls: ['./acquaintance-grid.component.css']
})
export class AcquaintanceGridComponent implements OnInit {

  constructor(private acquaintanceService: AcquaintanceService) { }

  ngOnInit() {
    var res;
    this.acquaintanceService.getAcquaintancies().subscribe((data: AcquaintanceResponseModel) => {
      res = data
      console.log(res);
    }
    );
    console.log(res);
  }

}

import { Component, OnInit } from '@angular/core';
import { TextService } from '../shared-services/text.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

  title = 'angular';

  constructor(public txt: TextService)  {  }

    async ngOnInit(){
      this.txt.texts = await this.txt.getTexts('en');
  }
}

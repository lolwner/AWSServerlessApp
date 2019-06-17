import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AcquaintanceGridComponent } from './acquaintance-grid.component';

describe('AcquaintanceGridComponent', () => {
  let component: AcquaintanceGridComponent;
  let fixture: ComponentFixture<AcquaintanceGridComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AcquaintanceGridComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AcquaintanceGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

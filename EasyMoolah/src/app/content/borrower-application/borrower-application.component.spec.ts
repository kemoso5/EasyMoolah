import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BorrowerApplicationComponent } from './borrower-application.component';

describe('BorrowerApplicationComponent', () => {
  let component: BorrowerApplicationComponent;
  let fixture: ComponentFixture<BorrowerApplicationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BorrowerApplicationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BorrowerApplicationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { JDataTableModule } from './j-data-table.module';

describe('JDataTableModule', () => {
  let jDataTableModule: JDataTableModule;

  beforeEach(() => {
    jDataTableModule = new JDataTableModule();
  });

  it('should create an instance', () => {
    expect(jDataTableModule).toBeTruthy();
  });
});

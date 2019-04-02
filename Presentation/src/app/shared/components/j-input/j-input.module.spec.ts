import { JInputModule } from './j-input.module';

describe('JInputModule', () => {
  let jInputModule: JInputModule;

  beforeEach(() => {
    jInputModule = new JInputModule();
  });

  it('should create an instance', () => {
    expect(jInputModule).toBeTruthy();
  });
});

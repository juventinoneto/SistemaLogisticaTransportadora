import { JTextareaModule } from './j-textarea.module';

describe('JTextareaModule', () => {
  let jTextareaModule: JTextareaModule;

  beforeEach(() => {
    jTextareaModule = new JTextareaModule();
  });

  it('should create an instance', () => {
    expect(jTextareaModule).toBeTruthy();
  });
});

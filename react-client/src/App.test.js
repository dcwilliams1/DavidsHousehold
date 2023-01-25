import {render, unmountComponentAtNode} from "react-dom";
import NetWorth from './investments/netWorth';

test('renders NetWorth element', () => {
  const div = document.createElement("div");
  render(<NetWorth />, div);
  unmountComponentAtNode(div);
});

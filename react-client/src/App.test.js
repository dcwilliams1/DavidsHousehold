import { render, screen } from '@testing-library/react';
import {ReactDom} from "react-dom";
import App from './index';
import NetWorth from './investments/netWorth';

test('renders NetWorth element', () => {
  const div = document.createElement("div");
  ReactDom.render(<NetWorth />, div);
  ReactDom.unmountComponentAtNode(div);
});

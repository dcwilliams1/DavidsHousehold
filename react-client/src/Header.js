import logo from "./favicon.ico";

const Header = (props) => (
  <header className="row">
    <div className="row page-title">
      <div className="col-md-3">
        <a href="/">
          <img src={logo} className="logo" alt="David's Household" />
        </a>
      </div>
      <div className="col-md-6">David and Beth's Household</div>
    </div>
    <div className="row">
      <div className="col-md-7 mt-5 subtitle">{props.subtitle}</div>
    </div>
  </header>
);

export default Header;

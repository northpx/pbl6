import React from "react";

import { Navbar } from "../Components/Navbar/Navbar";

import Routers from "../routers/Routers";


const Layout = () => {
  return (
    <div>
      {/* <Navbar /> */}

      <div>
        <Routers />
      </div>
    </div>
  );
};

export default Layout;
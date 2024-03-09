import { Col, Container, Row } from "react-bootstrap";
import NavComponent from "./Nav";
import Sidebar from "./Sidebar";

import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Home from '../pages/Home';
import StudentPage from '../pages/Student';
import Enzebaty from '../pages/Enzebaty';
import NotFound from "../pages/404";

function Layout() {
    return (<Container dir='rtl'>
        <Row>
            <NavComponent />
        </Row>

        <Row className='body'>
            <Col md={3} className='sidebar'>
                <Sidebar />
            </Col>

            <Col md={9} className='main'>
                <BrowserRouter>
                    <Routes>
                        <Route path="/" element={<Home />} />
                        <Route path='student' element={<StudentPage />} />
                        <Route path='enzebat' element={<Enzebaty />} />
                        <Route path="*" element={<NotFound />}  />
                    </Routes>
                </BrowserRouter>
            </Col>
        </Row>
    </Container>)
}


export default Layout;
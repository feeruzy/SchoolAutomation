import { useState } from 'react'
import { Accordion, Col, Container, ListGroup, Nav, Navbar, Row } from 'react-bootstrap'
import './assets/fonts/Vazirmatn-FD-Regular.ttf'
import './assets/fonts/Vazirmatn-FD-Medium.ttf'
import './assets/fonts/Vazirmatn-FD-Bold.ttf'

import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'

function App() {

  return (
    <Container dir='rtl'>
      <Row>
        <Navbar>
          <Navbar.Brand href="#home">مدرسه من</Navbar.Brand>
          <Nav className="me-auto">
            <Nav.Link>درباره</Nav.Link>
            <Nav.Link href="login">نام کاربر</Nav.Link>
          </Nav>
        </Navbar>
      </Row>

      <Row className='body'>
        <Col md={3} className='sidebar'>
          <Accordion defaultActiveKey="0">
            <Accordion.Item eventKey="0">
              <Accordion.Header>اطلاعات پایه</Accordion.Header>
              <Accordion.Body>
                <ListGroup>
                  <ListGroup.Item action>دانش آموزان</ListGroup.Item>
                  <ListGroup.Item action>پایه‌های تحصیلی</ListGroup.Item>
                  <ListGroup.Item action>رشته‌های تحصیلی</ListGroup.Item>
                  <ListGroup.Item action>دروس</ListGroup.Item>
                  <ListGroup.Item action>موارد انضباطی</ListGroup.Item>
                </ListGroup>
              </Accordion.Body>
            </Accordion.Item>
            <Accordion.Item eventKey="1">
              <Accordion.Header>کارتابل‌</Accordion.Header>
              <Accordion.Body>
                <ListGroup>
                  <ListGroup.Item action>ثبت نمره</ListGroup.Item>
                  <ListGroup.Item action>ثبت مورد انضباطی</ListGroup.Item>
                </ListGroup>
              </Accordion.Body>
            </Accordion.Item>
            <Accordion.Item eventKey="2">
              <Accordion.Header>گزارش‌ها</Accordion.Header>
              <Accordion.Body>
                <ListGroup>
                  <ListGroup.Item action>گزارش نمرات یک دانش آموز</ListGroup.Item>
                  <ListGroup.Item action>نمرات یک درس</ListGroup.Item>
                  <ListGroup.Item action>نمرات یک کلاس</ListGroup.Item>
                  <ListGroup.Item action>موارد انضباطی یک دانش آموز</ListGroup.Item>
                  <ListGroup.Item action>موارد انضباطی یک کلاس</ListGroup.Item>
                  <ListGroup.Item action>گزارش جامع یک دانش آموز</ListGroup.Item>
                </ListGroup>
              </Accordion.Body>
            </Accordion.Item>
          </Accordion>
        </Col>

        <Col md={9} className='main'>
          <Accordion defaultActiveKey="0">
            <Accordion.Item eventKey='0'>
              <Accordion.Header>عنوان صفحه</Accordion.Header>
              <Accordion.Body>
                test
              </Accordion.Body>
            </Accordion.Item>
          </Accordion>
        </Col>
      </Row>
    </Container>
  )
}

export default App

import './assets/fonts/Vazirmatn-FD-Regular.ttf'
import './assets/fonts/Vazirmatn-FD-Medium.ttf'
import './assets/fonts/Vazirmatn-FD-Bold.ttf'
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'

import { Col, Container, Row } from 'react-bootstrap'
import NavComponent from './components/Nav'
import Sidebar from './components/Sidebar'
import MainWindow from './components/MainWindow';

function App() {

  return (
    <Container dir='rtl'>
      <Row>
        <NavComponent />
      </Row>

      <Row className='body'>
        <Col md={3} className='sidebar'>
          <Sidebar />
        </Col>

        <Col md={9} className='main'>
          <MainWindow title="صفحه اصلی" />
        </Col>
      </Row>
    </Container>
  )
}

export default App

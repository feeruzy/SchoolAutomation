import { Accordion } from "react-bootstrap"
import Swr from '../components/Swr'

function StudentPage() {
    return (
        <Accordion defaultActiveKey="0">
            <Accordion.Item eventKey='0'>
                <Accordion.Header>کارتابل دانش آموزان</Accordion.Header>
                <Accordion.Body>
                    <Swr req={{ type: 'StudentList' }} />
                </Accordion.Body>
            </Accordion.Item>
        </Accordion>
    )
}

export default StudentPage
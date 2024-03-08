import { Accordion } from "react-bootstrap";
import Swr from "./Swr";

function MainWindow({ title }) {
    return (
        <Accordion defaultActiveKey="0">
            <Accordion.Item eventKey='0'>
                <Accordion.Header>{title}</Accordion.Header>
                <Accordion.Body>
                    <Swr req={{ type: 'StudentList' }} />
                </Accordion.Body>
            </Accordion.Item>
        </Accordion>
    )
}

export default MainWindow;
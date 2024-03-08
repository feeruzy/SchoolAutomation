import useSWR from 'swr'
import StudentManager from './Student';

const api = 'https://localhost:7033/School/';

const fetcher = (...args) => fetch(...args).then((res) => res.json());

const Swr = ({ req }) => {
    const { data, error, isLoading } = useSWR(api + req.type, fetcher);
    if (error) return <div>failed to load!</div>;
    if (isLoading) return <div>Loading ...</div>;

    switch (req.type) {
        case 'StudentList':
            return <StudentManager data={data} />;

        default:
            break;
    }
}


export default Swr;